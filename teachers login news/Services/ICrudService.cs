using System;
namespace teachers_login_news
{
    internal interface ICrudService
	{
		void Add(Person person);

		void Update(int id, Person person);

		void Delete(int id);

		Person Get(int id);

		Person[] GetAll();

	}
}

