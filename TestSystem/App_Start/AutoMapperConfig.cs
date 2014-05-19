using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace TestSystem
{
    public class AutoMapperConfig
    {
        public static void ConfigMappings()
        {
            Mapper.CreateMap<Entities.Question, Models.Question>().ConvertUsing<QuestionConverter>();

            Mapper.CreateMap<Entities.Option, Models.Option>();
            Mapper.CreateMap<Entities.InputQuestion, Models.InputQuestion>();            
            Mapper.CreateMap<Entities.SingleQuestion, Models.SingleQuestion>();
            Mapper.CreateMap<Entities.MultiplyQuestion, Models.MultiplyQuestion>();

            Mapper.CreateMap<Models.Option, Entities.Option>();
            Mapper.CreateMap<Models.InputQuestion, Entities.InputQuestion>();
            Mapper.CreateMap<Models.SingleQuestion, Entities.SingleQuestion>();
            Mapper.CreateMap<Models.MultiplyQuestion, Entities.MultiplyQuestion>();

            Mapper.AssertConfigurationIsValid();            
        }

        public class QuestionConverter : ITypeConverter<Entities.Question, Models.Question>
        {
            public Models.Question Convert(ResolutionContext context)
            {
                if (context.SourceValue is Entities.InputQuestion)
                {
                    return Mapper.Map<Models.InputQuestion>(context.SourceValue);
                }
                else if (context.SourceValue is Entities.SingleQuestion)
                {
                    return Mapper.Map<Models.SingleQuestion>(context.SourceValue);
                }
                else if(context.SourceValue is Entities.MultiplyQuestion)
                {
                    return Mapper.Map<Models.MultiplyQuestion>(context.SourceValue);
                }
                else
                {
                    throw new InvalidCastException();
                }
            }
        }
    }
}