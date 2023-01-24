using System;

namespace teachers_login_news.managers
{
    internal class TeacherManager : ICrudService, IPrintService
    {
        private Teachers[] _teachers = new Teachers[100];
        private int _currentIndex = 0;

        public void Add(Person person)
        {if(_currentIndex>99)
            {
                Console.WriteLine("limit kecildi 100 mellim daxil edile biler");
                return;
            }
            _teachers[_currentIndex] = (Teachers)person;
            _currentIndex++;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public Person[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            foreach (var item in _teachers) 
            {
                if (item == null) 
                    continue;
                Console.WriteLine(item.ToString());
            }
        }

       

        public void Update(int id, Person person)
        {
            throw new NotImplementedException();
        }
    }
}

