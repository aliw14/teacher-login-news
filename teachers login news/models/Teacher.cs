namespace teachers_login_news
{
    internal class Teachers:Person
	{
		internal string Profession { get; set; }

		internal DateTime EntryDate { get; set; }

        public override string ToString()
        {
            return $"{Id}\n{Firstname} {lastname}\n{Profession}\n{EntryDate}";
        }

    }
}

