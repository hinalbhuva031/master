﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.Swagger;

namespace ExamDemo.BusinessEntities.Contracts

{
    public interface IExamRegistrationService
    {
        Response CreateExamRegistration();
    }
}
