﻿namespace Machete.TranslateConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Translators.PropertyTranslaters;


    public class CopyInputValuePropertyTranslatorSpecification<TResult, TValue, TInput, TSchema> :
        PropertyTranslatorSpecification<TResult, Value<TValue>, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        public CopyInputValuePropertyTranslatorSpecification(Expression<Func<TResult, Value<TValue>>> propertyExpression) :
            base(propertyExpression)
        {
        }

        public CopyInputValuePropertyTranslatorSpecification(PropertyInfo propertyInfo) :
            base(propertyInfo)
        {
        }

        public CopyInputValuePropertyTranslatorSpecification(Expression<Func<TResult, Value<TValue>>> propertyExpression,
            Expression<Func<TInput, Value<TValue>>> inputPropertyExpression)
            : base(propertyExpression, inputPropertyExpression)
        {
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public override void Apply(IEntityTranslatorBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new CopyValuePropertyTranslator<TResult, TValue, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo, InputPropertyInfo);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}