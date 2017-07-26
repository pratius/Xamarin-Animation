using System;
using System.Collections.ObjectModel;
using DemoApp.Models;

namespace DemoApp.ViewModels
{
    public class ReportViewModel
    {
        public ReportViewModel()
        {
            ReportList = new ObservableCollection<Report>();
			ReportList.Add(new Report { Image = "Report", Name = "Report 1" });
			ReportList.Add(new Report { Image = "Report", Name = "Report 2" });
			ReportList.Add(new Report { Image = "Report", Name = "Report 3" });
			ReportList.Add(new Report { Image = "Report", Name = "Report 4" });
			ReportList.Add(new Report { Image = "Report", Name = "Report 5" });
			ReportList.Add(new Report { Image = "Report", Name = "Report 6" });
			ReportList.Add(new Report { Image = "Report", Name = "Report 7" });
			ReportList.Add(new Report { Image = "Report", Name = "Report 8" });
			ReportList.Add(new Report { Image = "Report", Name = "Report 9" });
			ReportList.Add(new Report { Image = "Report", Name = "Report 10" });
		}


        private ObservableCollection<Report> reportList;
        /// <summary>
        /// Get and set the user menu list
        /// </summary>
        public ObservableCollection<Report> ReportList
        {
            get { return reportList; }
            set { reportList = value; }
        }


    }
}
