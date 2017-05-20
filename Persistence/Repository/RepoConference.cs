﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class RepoConference
    {
        List<Model.Conference> conferences=new List<Model.Conference>();
        /*Function which adds a new conference.
        * In:Conference details
        * Out:new conference in the list
        * Conditions which are checked in repository:
        * DeadlineAbstract < DeadlineComplet < DeadlineParticipation < DeadlineBidding < DeadlineEvaluation < BeginDate < EndDate
        * AdmissionPrice>0
        * Id-unique
        */
        public void addConference(Model.Conference c)
        {
            if (c.AdmissionPrice < 1)
            {
                throw new RepositoryException("Conference admission price must be >=1!");
            }
            if ((DateTime.Compare(c.DeadlineAbstract, c.DeadlineComplet) < 0) && (DateTime.Compare(c.DeadlineComplet, c.DeadlineParticipation) < 0) && (DateTime.Compare(c.DeadlineParticipation, c.DeadlineBidding) < 0))
            {
                if ((DateTime.Compare(c.DeadlineBidding, c.DeadlineEvaluation) < 0) && (DateTime.Compare(c.DeadlineEvaluation, c.BeginDate) < 0) && (DateTime.Compare(c.BeginDate, c.EndDate) < 0))
                {
                    foreach (Model.Conference conf in getConferences())
                    {
                        if (conf.Id == c.Id)
                        {
                            throw new RepositoryException("Conference already exist!");
                        }
                    }

                    using (var context = new ISSEntities2(Util.ConnectionStringWithPassword.doIt()))
                    {
                        Conference conference = new Conference();
                        conference.ConferenceId = c.Id;
                        conference.Name = c.Name;
                        conference.Edition = c.Edition;
                        conference.DeadlineAbstractPaper = c.DeadlineAbstract;
                        conference.DeadlineBiddingPaper = c.DeadlineBidding;
                        conference.DeadlineCompletePaper = c.DeadlineComplet;
                        conference.DeadlineEvaluation = c.DeadlineEvaluation;
                        conference.DeadlineParticipation = c.DeadlineParticipation;
                        conference.EndDate = c.EndDate;
                        conference.BeginDate = c.BeginDate;
                        conference.City = c.City;
                        conference.Country = c.Country;
                        conference.Website = c.Website;
                        conference.Price = c.AdmissionPrice;

                        if (Find(conference.ConferenceId) == false)
                        {
                            context.Conferences.Add(conference);
                            context.SaveChanges();
                        }
                        else throw new RepositoryException("Conference already exists!");
                    }
                        //conferences.Add(c);
                    //TO DO->ADD PC MEMBERS.Astept functia
                }
                else
                {
                    throw new RepositoryException("Dates must be in chronological order!");
                }
            }
            else
            {
                throw new RepositoryException("Dates must be in chronological order!");
            }
        }


        public bool Find(int id)
        {
            using (var context = new ISSEntities2(Util.ConnectionStringWithPassword.doIt()))
            {
                var u = context.Conferences.Find(id);   
                if (u != null)
                {
                    return true;
                }
                return false;
               // return new Model.Conference(u.ConferenceId,u.Name,u.Edition,u.Topics,u.DeadlineAbstractPaper,u.DeadlineCompletePaper,u.DeadlineBiddingPaper,u.DeadlineEvaluation,u.DeadlineParticipation,u.City,u.Country,u.Website,u.Price,u.BeginDate,u.EndDate);
            }
        }


        public List<Model.Conference> getConferences()
        {
            return conferences;
        }
    }
}

