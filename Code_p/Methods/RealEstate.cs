using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace methods
{
    public class RealEstate
    // {
    //     public string Address { get; set; }
    //     public int Price { get; set; }
    //     public int SquareFeat { get; set; }
    //     public int CalculatePricePerSquareFeat() => Price / SquareFeat;
    // }
    // down code is for TUPPLES
    {
        private string _address;
        public RealEstate(string address)
        {
            _address = address;
        }
        public string Address 
        { 
            get => _address; 
            set => _address = value; 
        }
    }
}