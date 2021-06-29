using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    public class Block
    {
        private string _RGBString;
        private int _valueOnMap;
        private char _viewCharacter;

        public static List<Block> blocksList;
        static Block()
        {
            blocksList = new List<Block>();
        }
        public Block(string RGBString, int valueOnMap, char viewCharacter)
        {
            _RGBString = RGBString;
            _valueOnMap = valueOnMap;
            _viewCharacter = viewCharacter;
            Block.blocksList.Add(this); //add created block to list
        }
        public string Print()
        {
            return "RGB = " + _RGBString + "\tValue on map = " + _valueOnMap + "\tCharacter on map = " + _viewCharacter; 
        }
        public bool CompareRGBString(string value) //compare RGB strings, eg. "255 000 000"
        {
            return _RGBString.Equals(value);
        }
        public bool CompareValueOnMap(int value) //compare value in map
        {
            return value == _valueOnMap;
        }
        public char ViewCharacter
        {
            get
            {
                return _viewCharacter;
            }
        }
        public int ValueOnMap
        {
            get
            {
                return _valueOnMap;
            }
        }

        public static void InitialiseBlocks() //create all blocks
        {
            // add new blocks here
            new Block("000 000 000", -1, Convert.ToChar(9441 + 178)); // unpassable wall
            new Block("255 255 255", 0, '_'); // passable ground, plain
            new Block("050 000 000", 90, Convert.ToChar(9441 + 177)); // unlockable door
            new Block("255 000 000", 20, 'w'); // warrior
            new Block("255 100 100", 21, 'W'); // warior stronger
            new Block("000 000 255", 22, 'm'); // mage
            new Block("100 100 255", 23, 'M'); // mage stronger
            new Block("255 255 000", 101, 'X'); // end point
            new Block("111 111 111", 1, 'O'); // //start point is an active block and is not displayed on map, this represents player character block and first position

        }
    }
}
