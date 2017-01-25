﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyStudyProject.Core.Contracts.Interface.Cqrs.Command;
using MyStudyProject.Core.Cqrs.Abstract;
using MyStudyProject.Core.Models.Commands;
using MyStudyProject.Data.Contracts.ServiceFacades;
using MyStudyProject.Shared.Contracts.Enums;

namespace MyStudyProject.Domain.Cqrs.Twitter.Handlers
{
    public class TwitterMesssagesCreateCommandHandler : CommandHandler<MessagesCreateCommand>
    {
        private readonly ITwitterMessageFacade facade;

        public TwitterMesssagesCreateCommandHandler(ITwitterMessageFacade facade)
        {
            this.facade = facade;
        }

        public override Task<ICommandResult> ExecuteAsync(MessagesCreateCommand command)
        {
            var filtered = command.Messages.Where(x => x.MediaType != SocialMediaType.Twitter && x.Id <= 0);
            return facade.Save(filtered);
        }
    }
}
