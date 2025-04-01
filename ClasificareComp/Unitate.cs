using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Flags]
public enum Unitate
{
    pico  = 0b00000001,
    nano  = 0b00000010,
    micro = 0b00000100,
    mili  = 0b00001000,
    fara  = 0b00010000,
    kilo  = 0b00100000,
    mega  = 0b01000000,
    giga  = 0b10000000
}