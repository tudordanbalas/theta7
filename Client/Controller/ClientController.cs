﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Model;
using Server;
namespace Client
{
    public class ClientController : MarshalByRefObject, IClient
    {
        private readonly IServer server;
        private User currentUser;

        public ClientController(IServer server)
        {
            this.server = server;
            this.currentUser = null;
        }

        ///CONFERENCE
        
        public void updatedConference(Conference c)
        {
            throw new NotImplementedException();
        }
        public List<Model.Conference> getAllConferences()
        {
            return server.GetConferences();
        }
        public Model.Conference getConference(string name, string edition, string city)
        {
            List<Model.Conference> allConferences = getAllConferences();
            foreach (Model.Conference conference in allConferences)
            {
                if (conference.Name.Equals(name) && conference.Edition.Equals(edition) && conference.City.Equals(city))
                    return conference;
            }
            return null;
        }
        public List<Model.Conference> getMyConferences() //daca am timp o voi face mai frumoasa; daca aveti timp, feel free and change it
        {
            List<Model.Conference> allConferences = getAllConferences();
            List<Model.Conference> myConferences = new List<Model.Conference>();
            foreach (Conference conference in allConferences)
            {
                foreach (Participant participant in conference.Participants)
                {
                    if (participant.User.Name.Equals(currentUser.Name))
                    {
                        myConferences.Add(conference);
                        break;
                    }
                }
            }
            return myConferences;
        }
        public void AddConference(string name, string edition, List<string> topics, DateTime deadlineAbstract,
                DateTime deadlineComplet, DateTime deadlineBidding, DateTime deadlineEvaluation, DateTime deadlineParticipation,
                string city, string country, string website, double admissionPrice, DateTime beginDate, DateTime endDate)
        {
            Conference conference = new Conference(-1, name, edition, topics, deadlineAbstract, deadlineComplet, deadlineBidding, deadlineEvaluation, deadlineParticipation,
                city, country, website, admissionPrice, beginDate, endDate);
            server.AddConference(conference);
        }

        ///PAPER

        public void updatedPaper(Paper p)
        {
            throw new NotImplementedException();
        }

        public List<Model.Paper> getPapers(Conference conference)
        {
            //ar trebui sa returneze toate lucrarile userului curent la conferinta data ca parametru
            return new List<Model.Paper>();
        }

        ///USER

        public bool login(string username, string password)
        {
            try
            {
                User user = new User(username, password);
                server.Login(user, this);
                currentUser = user;
                return true;
            } catch(ServerException err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
        }
        public void logout()
        {
            try
            {
                server.Logout(currentUser, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public bool register(string username, string password, string name, string affiliation, string email, string website, bool isSpecial)
        {
            try
            {
                User user = new User(-1, username, password, name, affiliation, email, isSpecial, website);
                server.Register(user);
                return true;
            } catch(ServerException err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
        }
        public List<Model.User> GetAllUsers()
        {
            return server.GetAllUsers();
        }
        public string getMyRank(string name, string edition, string city)
        {
            List<Model.Conference> allConferences = getAllConferences();
            foreach (Model.Conference conference in allConferences)
            {
                if (conference.Name.Equals(name) && conference.Edition.Equals(edition) && conference.City.Equals(city))
                    foreach (Model.Participant participant in conference.Participants)
                        if (participant.User.Name.Equals(currentUser.Name))
                        {
                            if (participant.IsChair)
                                return "Chair";
                            if (participant.IsCochair)
                                return "CoChair";
                            if (participant.CanBePCMember)
                                return "PCMember";
                            else
                                return "NormalUser";
                        }
            }
            return "Unregistered";
        }
        public List<Model.User> GetSpecialUsers()
        {
            return server.GetSpecialUsers();
        }

        ///PARTICIPANT

        public List<Model.Participant> getChairs(Conference conference)
        {
            List<Model.Participant> chairList = new List<Model.Participant>();
            foreach(Model.Participant participant in conference.Participants)
            {
                if (participant.IsChair || participant.IsCochair)
                    chairList.Add(participant);
            }
            return chairList;
        }

        public List<Model.Participant> getPCMembers(Conference conference)
        {
            List<Model.Participant> memberList = new List<Model.Participant>();
            foreach (Model.Participant participant in conference.Participants)
            {
                if (participant.CanBePCMember)
                    memberList.Add(participant);
            }
            return memberList;
        }

        public void addParticipant(Participant p)
        {
            server.AddParticipant(p);
        }

        ///REVIEW

        public List<Review> getReviewsByPaper(string title)
        {
            return new List<Review>();
            //ar trebui sa returneze reviewurile dupa titlu si current user
        }
        public void addReview(int paperId, Review r)
        {
            server.AddReview(paperId, r);
        }
    }
}
