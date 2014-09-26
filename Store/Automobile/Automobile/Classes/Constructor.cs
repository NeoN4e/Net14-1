 // 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automobile
{
    partial class Auto
    {
       public Auto ( string vendor = "ВАЗ", string model = "2101", string typeBody = "Pickup", string color = "Салатовый", int doors = 4)
       {
           // Прием параметров в конструкторе
           this.vendor     = vendor;       // производитель
           this.model      = model;        // модель
           this.typeBody   = typeBody;     // тип кузова
           this.color      = color;        // цвет
           this.countDoors = doors;        // кол-во дверей

           this.speed      = 0;            // скорость
           this.status     = "stopping";   // состояние двигателя (вкл / выкл)
           this.fuel       = true;         // наличие бензина
           this.stops      = false;        // стопы (горят или нет)
           this.handBreak  = false;        // ручной тормоз
           
           this.pedals     = new bool[] { false, false, false };                              // 1 - газ | 2 - тормоз | 3 - сцепление
           this.gears      = new bool []{false, true, false, false, false, false, false };    // R N 1 2 3 4 5
           
           this.current    = 0;             // для более корректной работы метода Menu()
       }
    }
    
}
