﻿namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Builders;
    using Configuration;


    public class LayoutSpecification<TLayout, TSchema> :
        ILayoutSpecification<TSchema>
        where TSchema : Entity
        where TLayout : Layout
    {
        readonly IDictionary<string, ILayoutPropertySpecification<TLayout, TSchema>> _specifications;

        public LayoutSpecification()
        {
            _specifications = new Dictionary<string, ILayoutPropertySpecification<TLayout, TSchema>>();
        }
        public string Name { get; set; }

        public void Add(string propertyName, ILayoutPropertySpecification<TLayout, TSchema> specification)
        {
            _specifications[propertyName] = specification;
        }

        public Type LayoutType => typeof(TLayout);

        public IEnumerable<Type> GetReferencedLayoutTypes()
        {
            return _specifications.Values.SelectMany(x => x.GetReferencedLayoutTypes());
        }

        public void Apply(ISchemaLayoutBuilder<TSchema> builder)
        {
            BuildFormatter(builder);
            
            BuildLayout(builder);
        }

        void BuildLayout(ISchemaLayoutBuilder<TSchema> builder)
        {
            var layoutBuilder = new DynamicLayoutBuilder<TLayout, TSchema>(builder);

            foreach (var specification in _specifications.Values)
            {
                specification.Apply(layoutBuilder);
            }

            var map = layoutBuilder.Build();

            builder.Add(map);
        }

        void BuildFormatter(ISchemaLayoutBuilder<TSchema> builder)
        {
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.Values.SelectMany(x => x.Validate());
        }
    }
}