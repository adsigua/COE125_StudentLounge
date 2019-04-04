using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COE125 {
    public class User {
        int id;
        string username;
        string name;
        int role;
        int numPost;
        int numThanks;
        int[] ranking = new int[5]; //ranking math/physics/mec/cpe/chm

        public User() {; }

        public User(int i, string un, string n, int r, int nP, int nT, int[] rn) {
            id = i;
            username = un;
            name = n;
            role = r;
            numPost = nP;
            numThanks = nT;
            ranking = rn;
        }

        public int nPost {
            get { return numPost; }
            set { numPost = value; }
        }

        public int nThanks {
            get { return numThanks; }
            set { numThanks = value; }
        }

        public int roleInt {
            get { return role; }
            set { role = value; }
        }

        public string getUserName() {
            return username;
        }

        public string getName() {
            return name;
        }
        
        public int getId() {
            return id;
        }

        public int getRanking(int ind) {
            return ranking[ind];
        }


        public string getRankingStr() {
            int rValue = numThanks / 10;
            
            string str = rValue>=10 ?  "Deus" :
            rValue == 9 ? "Caeser"  :  
            rValue == 8 ? "Consul"  :
            rValue == 7 ? "Senatores" :
            rValue == 6 ? "Equitum" :
            rValue == 5 ? "Triarii" :
            rValue == 4 ? "Principes" :
            rValue == 3 ? "Hastati" :
            rValue == 2 ? "Leves" :
            rValue == 1 ? "Accensi" :
            "Proletarii";
            
            return str;
        }   


        public string getRoleStr() {
            switch (role) {
                case 1:
                    return "user";
                case 2:
                    return "moderator";
                case 3:
                    return "admin";
                default:
                    return "anonymous";
            }
        }



    }
}