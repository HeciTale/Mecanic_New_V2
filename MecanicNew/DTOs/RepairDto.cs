﻿namespace MecanicNew.DTOs
{
    public class RepairDto
    {
        public string CarNumber { get; set; }
        public string CarOwner { get; set; }
        public string Mecanic {  get; set; }
        public DateTime DateTime { get; set; }
        public int Price { get; set; }

        public int Pay {  get; set; }

    }
}
