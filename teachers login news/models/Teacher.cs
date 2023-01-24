namespace teachers_login_news
{
    internal class Teachers:Person
	{
		internal string Profession { get; set; }

		internal DateTime EntryDate { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\nAge:{Age}\nAd,Soyad:{Firstname} {lastname}\nProfession:{Profession}\nEntryDate:{EntryDate}";
        }

    }
}

