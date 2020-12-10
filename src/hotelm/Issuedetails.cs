using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotels
{
    
    public class Issuedetails
    {

        public int Roomno
        {
            get;
            set;
        }
        public string Issue
        {
            get;
            set;
        }

        public Issuedetails()
        {
            IssuedetailsList = new List<Issuedetails>();
        }
        public Issuedetails(int Roomno, string Issue)
        {

            this.Roomno = Roomno;
            this.Issue = Issue;

        }
        public void setIssuedetails()
        {

            Console.Write("Enter your roomno : ");
            Roomno = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter your Issue: ");
            string Issue=Console.ReadLine();
            IssuedetailsList.Add(new Issuedetails(Roomno, Issue));
            Console.WriteLine("Your Issue is Succesfully added ");
        }

        public void ShowIssuedetails()
        { 
            Console.Write("Enter your roomno : ");
            Roomno = Convert.ToInt16(Console.ReadLine());
           var query=from Issuedetails in IssuedetailsList orderby select Issue;
            foreach (var issue in query)
            {
                 Console.WriteLine(issue);
            }


     
        }
          public List<Issuedetails> IssuedetailsList;
    }
    
}