﻿using System;
using System.Collections.Generic;

namespace Lesson06_Theoryy.Models;

public partial class Book
{
    public string BookId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Author { get; set; }

    public int? Release { get; set; }

    public double? Price { get; set; }

    public string? Picture { get; set; }

    public int? PublisherId { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Publisher? Publisher { get; set; }
}
