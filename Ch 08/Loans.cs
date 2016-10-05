using System;
using System.Collections;
using Membership;
using Books;

namespace Loans
{
    public class LoanManager
    {
        private static LoanManager mInstance;
        private Hashtable mLoans;

        private LoanManager()
        {
            mLoans = new Hashtable();
        }

        public static LoanManager Instance
        {
            get
            {
                if (mInstance == null)
                    mInstance = new LoanManager();
                return mInstance;
            }
        }

        public void BorrowBook(int BookID, int MemberID)
        {
            Inventory inv = Inventory.Instance;
            MemberManager mem = MemberManager.Instance;

            Book theBook = inv[BookID];
            Member theMember = mem[MemberID];

            if (theBook != null && theMember != null)
            {
                Loan theLoan = new Loan(theBook, theMember);
                mLoans[BookID] = theLoan;
                Console.WriteLine(theLoan.ToString());
            }
            else
                Console.WriteLine("Cannot borrow book");
        }

        public void ReturnBook(int BookID)
        {
            if (mLoans.ContainsKey(BookID))
            {
                mLoans.Remove(BookID);
                Console.WriteLine("Book {0} was returned", BookID);
            }
            else
                Console.WriteLine("Cannot return book");
        }
    }

    public class Loan
    {
        private Book mTheBook;
        private Member mTheMember;

        public Loan(Book TheBook, Member TheMember)
        {
            mTheBook = TheBook;
            mTheMember = TheMember;
        }

        public override string ToString()
        {
            return "Book: " + mTheBook.ToString() + "\nBorrowed by: " + mTheMember.ToString() + "\n";
        }
    }
}
