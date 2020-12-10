/*using System;
using System.Collections.Generic;
namespace Hotels
{
    public class getissueDetails
    {
       public void Showissuedetails()
        {
            var Issue = getissueDetails();
            if (Issue.ToList().Count > 0)
            {
                foreach (var issue in Issue)
                {
                    Console.WriteLine(Roomno+ "     " + Issue);
                }
            }
            else
            {
                Console.WriteLine("No issues are present");
            }
        }
        public List<Issuedetails> getissuedetails()
        {
            var Issue = from Issue in Issuedetails
                             orderby Issue.
                             select Issuedetails;
            return Issue;
        } 
    }
}
using System;
using System.Collections.Generic;
namespace Hotels
{
    public class getissuedetails
    {
        public void Showissuedetails()
        {
            foreach (var issue in IssuedetailsList)
            {
                Console.WriteLine(issue.Roomno + "    " + issue.Issue);
            }
     
        }
    
}
}*/