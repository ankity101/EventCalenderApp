using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace practice.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			/* Month Data */

			List<SelectListItem> items = new List<SelectListItem>();
			SelectListItem item0 = new SelectListItem() { Text = "Select Month", Value = "1", Selected = true };
			items.Add(item0);
			for (int j = 1; j <= 12; j++)
			{
				DateTime date = new DateTime(2023, j, 1);
				string month_name = date.ToString("MMMM");
				string month = j.ToString();
				items.Add(
					new SelectListItem() { Text = month_name, Value = month, Selected = false });
			}
			ViewBag.Months = items;

			/* Year Data  */

			List<SelectListItem> Year = new List<SelectListItem>();
			SelectListItem year1 = new SelectListItem() { Text = "Select Year", Value = "2023", Selected = true };
			Year.Add(year1);
			for (int i = 1990; i <= 2070; i++)
			{
				string year = i.ToString();
				Year.Add(new SelectListItem() { Text = year, Value = year, Selected = false });
			}
			ViewBag.Year = Year;
			return View();
		}

		public ActionResult Index2(int? value1, int? value2)
		{
			ViewBag.Month = value1;
			ViewBag.Year = value2;
			return View();
		}
	}
}
 
/*
 <br />
<br />

<h2 style="color:aqua;  text-align: center">Please Select Year</h2>
<br />
<br />
@{
    <div style="color: red; text-align: center">

        @{
            var year = @ViewBag.Year;
            <p>@year</p>
         
        @Html.DropDownList("Months",null,
        new {@id = "ProjectId"})
        <br />
        }
        @section Scripts
            {
            <script language="javascript" type="text/javascript">
                $(document).ready(function () {

                $("#ProjectId").change(function () {

                var projectId = $('#ProjectId').val();
                 
                var categoryId = @year;
                window.location.href = '@Url.Action("Index3","Home")' + '?value1=' + projectId + '&value2=' + categoryId;
                });

                });
            </script>

        }
         

    </div>

}

   
 */