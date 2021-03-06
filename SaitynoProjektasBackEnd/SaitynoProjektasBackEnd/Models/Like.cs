﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SaitynoProjektasBackEnd.Models
{
    public class Like
    {
        public int Id { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int SongId { get; set; }
        public Song Song { get; set; }
    }
}
