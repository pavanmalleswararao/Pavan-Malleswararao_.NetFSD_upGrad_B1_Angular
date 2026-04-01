using Assignmet1.Models;

namespace Assignmet1.ViewModels
{
    public class AccountRepository
    {
        private readonly AppContext _context;
        public AccountRepository()
        {
            _context = new AppContext();
        }

        public void AddAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void UpdateAccount(Account account)
        {
            _context.Accounts.Update(account);
            _context.SaveChanges();
        }

        public void DeleteAccount(int accountId)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.AccountId == accountId);
            _context.Accounts.Remove(account);
            _context.SaveChanges();
        }

        public Account GetAccount(int accountId)
        {
            var account = _context.Accounts.Find(accountId);
            return account;
        }

        public List<Account> GetAllAccounts()
        {
            var accounts = _context.Accounts.ToList();
            return accounts;
        }
    }
}
