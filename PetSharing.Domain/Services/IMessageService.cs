﻿using PetSharing.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetSharing.Domain.Services
{
    public interface IMessageService
    {
        IEnumerable<Message> GetMessages(User sender, User receiver);
        Message Create(Message messege);
        void Delete(int id);
    }
}
