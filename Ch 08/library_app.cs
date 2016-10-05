using System;
using System.Collections;
using Membership;
using Books;
using Loans;

namespace LibraryApp
{
    public class LibraryApp
    {
        [STAThread]
        public static void Main()
        {
            Inventory inv = Inventory.Instance;
            inv[7043] = new Book("Professional C#", "Robinson");
            inv[0871] = new Book("Instant UML", "Muller");

            MemberManager mem = MemberManager.Instance;
            mem[100] = new Member("Georgia", "5th Ave.", "New York");
            mem[101] = new Member("William", "Park Lane", "London");

            LoanManager loanmgr = LoanManager.Instance;
            loanmgr.BorrowBook(7043, 100);
            loanmgr.BorrowBook(0871, 101);

            loanmgr.ReturnBook(7043);
            loanmgr.ReturnBook(0871);
        }
    }
}
