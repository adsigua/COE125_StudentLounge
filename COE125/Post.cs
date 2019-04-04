using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COE125
{
    public class Post
    {
        int id;         //Post Id
        int paid;       //poster account id
        int pid;        //parent id (if post is reply)
        bool isReply;   //if post is reply
        DateTime dtPosted;  //Date of post
        int numRep;     //number of reply
        int numUp;      //number of upvotes
        List<int> tags = new List<int>();


        public Post() {; }

        public Post(int i,int pa, int pi, bool isR, DateTime dt, int numR, int numU, List<int> tg){
            id = i;
            paid = pa;
            pid = pi;
            isReply = isR;
            dtPosted = dt;
            numRep = numR;
            numUp = numU;
            tags = tg;
        }

        public int nReply{
            get { return numRep; }
            set { numRep = value; }
        }

        public int nUp {
            get { return numUp; }
            set { numUp = value; }
        }

        public int getId(){
            return pid;
        }

        public int getPaid()
        {
            if (!isReply)
                return paid;
            else
                return 0;
        }

        public int getPi() {
            return pid;
        }

        public string getDate() {
            return dtPosted.Year.ToString() + "/" + dtPosted.Month.ToString() + "/" + dtPosted.Day.ToString();
        }

        public List<string> getTags() {
            List<string> tgs = new List<string>();
            foreach(int x in tags){
                switch (x) {
                    case 0:
                        tgs.Add("Math");
                        break;
                    case 1:
                        tgs.Add("Physics");
                        break;
                    case 2:
                        tgs.Add("Mechanics");
                        break;
                    case 3:
                        tgs.Add("Programming");
                        break;
                    case 4:
                        tgs.Add("Chemistry");
                        break;
                    default:
                        tgs.Add("General");
                        break;
                }
            }
            if (tgs.Count <= 0)
                tgs.Add("General");
            return tgs;
        }
    }
}