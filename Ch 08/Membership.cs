using System;
using System.Collections;

namespace Membership
{
    public class MemberManager
    {
        private static MemberManager mInstance;
        private Hashtable mLibraryMembers;

        private MemberManager()
        {
            mLibraryMembers = new Hashtable();
        }

        public static MemberManager Instance
        {
            get
            {
                if (mInstance == null)
                    mInstance = new MemberManager();
                return mInstance;
            }
        }

public Member CreateMember (string name, string street, string city)
{
	Member newMem = new Member(name, street, city);
	mLibraryMembers[name] = newMem;
	return newMem;
	                              
}
        public Member this [int MemberID]
        {
            get { return (Member)mLibraryMembers[MemberID]; }
            set { mLibraryMembers[MemberID] = value; }
        }
    }

    public class Member
    {
        private string mName;
        private Address mAddress;

        public Member(string name, string street, string city)
        {
            mName = name;
            mAddress = new Address(street, city);
        }

        public override string ToString()
        {
            return mName + ", address: " + mAddress.ToString();
        }
    }

    public class Address
    {
        private string mStreet;
        private string mCity;

        public Address(string street, string city)
        {
            mStreet = street;
            mCity = city;
        }

        public override string ToString()
        {
            return mStreet + ", " + mCity;
        }
    }
}
