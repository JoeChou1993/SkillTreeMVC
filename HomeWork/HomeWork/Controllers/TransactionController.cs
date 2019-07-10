using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHomeWork.Models.ViewModels;

namespace MVCHomeWork.Controllers
{
    public class TransactionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Create()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult RecordList()
        {
            return View(this.TransactionRecordList(100));
        }

        private List<TransactionViewModels> TransactionRecordList(int RecordCount)
        {
            List<TransactionViewModels> tmpTransactionRecordList = new List<TransactionViewModels>();
            Random tmpRandom = new Random();

            for (int i = 1; i <= RecordCount; i++)
            {
                var tmpRecordData = new TransactionViewModels()
                {
                    Date = DateTime.Now.AddDays(-tmpRandom.Next(0, 30)),
                    Amount = (decimal)tmpRandom.Next(100, 9999),
                    Category = this.GetTransactionCategoryDesc(tmpRandom.Next(0, 100) % 2),
                };
                tmpTransactionRecordList.Add(tmpRecordData);
            }

            return tmpTransactionRecordList;
        }

        private string GetTransactionCategoryDesc(int CategoryCode)
        {
            switch (CategoryCode.ToString())
            {
                case "0":
                    return "支出";
                default:
                    return "收入";
            }
        }
    }
}