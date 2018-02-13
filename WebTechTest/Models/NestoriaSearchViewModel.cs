using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTechTest.Models.Nestoria;

namespace WebTechTest.Models
{
    public class NestoriaSearchViewModel
    {
        public string SearchTerm { get; set; }
        public RootObject ApiCallRootObject { get; set; }
    }
}