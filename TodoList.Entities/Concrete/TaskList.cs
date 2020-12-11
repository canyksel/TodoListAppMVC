using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TodoList.Entities.Concrete
{
    public class TaskList
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int TaskId { get; set; }
        [Display(Name = "Görevi Oluşturan Kişi")]
        [Required(ErrorMessage = " Bu Alan Boş Bırakılamaz")]
        public string CreatorName { get; set; }

        [Required(ErrorMessage = " Bu Alan Boş Bırakılamaz")]
        [Display(Name = "Görev Açıklaması")]
        public string TaskDescription { get; set; }
        [Required(ErrorMessage = " Bu Alan Boş Bırakılamaz")]
        [Display(Name = "Gerçekleşme durumu")]
        public bool IsComplete { get; set; }

        [Display(Name = "Görevin Oluşturulma Zamanı")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Bu Alan Boş Bırakılamaz")]
        public DateTime CreateTime { get; set; }

        [Display(Name = "Görevin Yapılacağı Tarih")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage =" Bu Alan Boş Bırakılamaz")]
        public DateTime TaskTime { get; set; }
    }
}
