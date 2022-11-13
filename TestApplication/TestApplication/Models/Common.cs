using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TestSelise.Models.Models;

namespace TestApplication.Models
{
    public class Common
    {
        public Common()
        {
            Divisions = new List<CommonCodeVM>();
        }
        public List<CommonCodeVM> Divisions { get; set; }

        public IEnumerable<SelectListItem> DivisionsSelectListItems => new SelectList(Divisions, "CommonCodeId", "Name");
        public IEnumerable<SelectListItem> GenderSelectListItem = new List<SelectListItem>
        {
            new SelectListItem{Text = "পুরুষ", Value="M"},
            new SelectListItem{Text = "মহিলা", Value="F"},
            new SelectListItem{Text = "৩য় লিঙ্গ", Value="O"}
        };
    }
}
