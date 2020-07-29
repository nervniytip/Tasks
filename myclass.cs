using System;
using System.Collections.Generic;
using System.Linq;using System.Text;

namespace Hello
{
    struct Train: IComparable
    {
        
        public string StartPlace;
        public string EndPlace;
        public string TrainNumber;
        public DateTime StartTime ;
        public DateTime ReturnTime;


       public Train ( string StartPlace, string EndPlace, string TrainNumber, DateTime StartTime, DateTime ReturnTime) //конструктор
        {
            this.StartPlace = StartPlace;
            this.EndPlace = EndPlace;
            this.TrainNumber = TrainNumber;
            this.StartTime = StartTime;
            this.ReturnTime = ReturnTime;
        }
          public int CompareTo(object o) // реализация интерфейса(сортировка по номеру поезда)
        {
            Train t=(Train)o ;
            if(TrainNumber.CompareTo(t.TrainNumber) ==-1) return -1;
            if(TrainNumber.CompareTo(t.TrainNumber) == 0) return 0;
            else return 1;
        }

        public static string ShowInformation( string trainNumber,Train[] array) //поиск по номеру
        {
            string return_string = null;
            var traininfo = from t in array
                            where t.TrainNumber == trainNumber 
                            select t;

            foreach(var t in traininfo)
            {
                return_string = $"Поезд № {t.TrainNumber}."
                                +$"\nОтправление {t.StartPlace} {t.StartTime.ToString("yyyy MM dd"+" в "+"hh:mm")}."
                                +$"\nПрибытие {t.EndPlace} {t.ReturnTime.ToString("yyyy MM dd"+" в "+"hh:mm")}";
            }
            return return_string;
            
        }

        public static void SortTrainByEndPlace(Train[] array) //сортировка по месту прибытия
        {
            //string s = null;
            var trainsotr = array.OrderBy(ep => ep.EndPlace).ThenBy(st=>st.StartTime);
            foreach(var train in trainsotr)
            {   
                //s = $" поезд № {train.TrainNumber} {train.StartPlace}-{train.EndPlace} отправление {train.StartTime}";
                Console.WriteLine($" поезд № {train.TrainNumber} {train.StartPlace}-{train.EndPlace} отправление {train.StartTime}"); 
            }
            //return s;
        }

      

        public override string ToString() => $" поезд № {this.TrainNumber} {this.StartPlace}-{this.EndPlace}"; 
        
    }
    
}
