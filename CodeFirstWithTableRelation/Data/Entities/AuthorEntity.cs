﻿namespace CodeFirstWithTableRelation.Data.Entities
{
    public class AuthorEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<BookEntity> Books { get; set; }
    }
}
