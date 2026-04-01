using Assignmet1.Models;
using Assignmet1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Assignmet1.Controllers
{
    public class AccountController : Controller
    {
        private AccountRepository _repo;
        public AccountController()
        {
            _repo = new AccountRepository();
        }
        public IActionResult Index()
        {
            var accounts = _repo.GetAllAccounts();
            return View(accounts);
        }

        public IActionResult Details(int AccountId)
        {
            var account = _repo.GetAccount(AccountId);
            return View(account);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Account account)
        {
            _repo.AddAccount(account);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int AccountId)
        {
            _repo.DeleteAccount(AccountId);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int AccountId)
        {
            var account=_repo.GetAccount(AccountId);
            return View(account);
        }
        [HttpPost]
        public IActionResult Edit(Account account)
        {
            _repo.UpdateAccount(account);
            return RedirectToAction("Index");
        }
    }
}
