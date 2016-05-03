using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoeRestaurant
{
    class MenuMaker
    {
        public Random Randomizer;
        string[] Meats = { "牛肉", "鮪魚", "火雞", "火腿", "熏牛肉" };
        string[] Condiment = { "黃芥末", "哇沙米", "番茄醬", "蜂蜜芥末醬", "沙拉醬" };
        string[] Breads = { "全麥", "蜂蜜燕麥", "巴馬乾酪", "白麵包", "家鄉麵包" };

        public string GetMenuItem()
        {
            string randomMent = Meats[Randomizer.Next(Meats.Length)];
            //取得一個小於meats元素數量的隨機值 0~4
            //string randomMent = Meats[Randomizer.Next(5)];
            string randomCondiment = Condiment[Randomizer.Next(Condiment.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];
            return randomMent + " with " + randomCondiment + " on " + randomBreads;
        }
    }
    
}
