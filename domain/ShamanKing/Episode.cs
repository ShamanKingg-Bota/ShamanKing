using System;

namespace ShamanKing
{
    public class Episode
    {
        public int Id { get; }//идентификатор, чтобы не путать
        public string Title { get; }//название эпизода,возвращаемый
        public Episode(int id, string title)//кажись конструктор?
        {
            Id = id;
            Title = title; //проинициализировать
        }

    }
}
