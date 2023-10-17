document.addEventListener("DOMContentLoaded", function () {
    const paintingTypeDropdown = document.getElementById("painting-type");
    const paintingText = document.getElementById("painting-text");
    const paintingQuantity = document.getElementById("painting-quantity");
    const paintingPrice = document.getElementById("painting-price");
    const addPaintingButton = document.getElementById("add-painting");

    const tables = {
        MTrans: {
            body: document.querySelector("#MTrans-table tbody"),
            totalSpan: document.getElementById("MTrans-total"),
            data: [],
        },
        Kenar: {
            body: document.querySelector("#Kenar-table tbody"),
            totalSpan: document.getElementById("Kenar-total"),
            data: [],
        },
        EmekHaqqi: {
            body: document.querySelector("#EmekHaqqi-table tbody"),
            totalSpan: document.getElementById("EmekHaqqi-total"),
            data: [],
        },
    };

    function updateTable(type) {
        const table = tables[type];
        const row = document.createElement("tr");
        const cells = [];

        ["painting-text", "painting-quantity", "painting-price"].forEach((inputId) => {
            const cell = document.createElement("td");
            cell.textContent = document.getElementById(inputId).value;
            cells.push(cell);
        });

        const totalValue = parseFloat(cells[1].textContent) * parseFloat(cells[2].textContent);
        cells.push(document.createElement("td"));
        cells[3].textContent = totalValue.toFixed(2);

        table.data.push(totalValue);

        cells.forEach((cell) => {
            row.appendChild(cell);
        });

        table.body.appendChild(row);

        const total = table.data.reduce((acc, curr) => acc + curr, 0);
        table.totalSpan.textContent = total.toFixed(2);
    }

    addPaintingButton.addEventListener("click", function () {
        const selectedType = paintingTypeDropdown.value;

        if (paintingText.value && paintingQuantity.value && paintingPrice.value) {
            updateTable(selectedType);
            ["painting-text", "painting-quantity", "painting-price"].forEach((inputId) => {
                document.getElementById(inputId).value = "";
            });

            const grandTotal = Object.values(tables).reduce((acc, table) => {
                return acc + table.data.reduce((total, value) => total + value, 0);
            }, 0);

            document.getElementById("grand-total").textContent = grandTotal.toFixed(2);
        }
    });
});
