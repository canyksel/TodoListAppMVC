using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoListMVCUI.Models
{
    public class PagingInfo
    {
        public int ItemsPerPage { get; internal set; }
        public int TotalItems { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}