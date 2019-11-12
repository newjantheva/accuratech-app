﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MigrationBait
{
    public class QueueItem
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public string Body { get; set; }
        public string Date { get; set; }
    }
}
