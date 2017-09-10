using FizzBuzzCommon.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzTest
{

    /// <summary>
    ///This is a test class for FizzBuzzModelTest and is intended
    ///to contain all FizzBuzzModelTest Unit Tests
    ///</summary>
    [TestFixture]
    public class FizzBuzzModelTest
    {
        private IList<object> attributes;

        /// <summary>
        ///A test for InputValue to check required attribute
        ///</summary>
        [Test]
        public void InputValueRequiredAttributeTest()
        {
            var expressoin = new Expression<Func<FizzBuzzModel, int>>(new FizzBuzzModel(){ InputValue}));

            var memberExpression = expression.Body as MemberExpression;
            attributes = memberExpression.Member.GetCustomAttributes(false);
   
            this.GetAttributes(m => m.InputValue);
            var attribute = this.CheckRequiredAttribute();
            this.AssertRequiredAttribute(attribute);
        }

        /// <summary>
        ///A test for InputValue to check regular expression attribute
        ///</summary>
        [Test]
        public void InputValueRegularExpressionAttributeTest()
        {
            this.GetAttributes(m => m.InputValue);
            var attribute = this.CheckRegularExpressionAttribute();
            this.AssertRegularExpressionAttribute(attribute);
        }

        /// <summary>
        /// Get list of all atributes for given property
        /// </summary>
        /// <param name="expression"></param>
        private void GetAttributes(Expression<Func<FizzBuzzModel, int>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            attributes = memberExpression.Member.GetCustomAttributes(false);
        }

        /// <summary>
        /// Get the required attribute from the attributes list
        /// </summary>
        /// <returns></returns>
        private object CheckRequiredAttribute()
        {
            return attributes.First(m => m.GetType() == typeof(RequiredAttribute));
        }

        /// <summary>
        /// Assert the required attribute object
        /// </summary>
        /// <param name="attribute"></param>
        private void AssertRequiredAttribute(object attribute)
        {
            Assert.IsNotNull(attribute);
            
        }

        /// <summary>
        /// Get the regula expression attribute from the attributes list
        /// </summary>
        /// <returns></returns>
        private object CheckRegularExpressionAttribute()
        {
            return attributes.First(m => m.GetType() == typeof(RegularExpressionAttribute));
        }

        /// <summary>
        /// Assert the regula expression attribute
        /// </summary>
        /// <param name="attribute"></param>
        private void AssertRegularExpressionAttribute(object attribute)
        {
            Assert.IsNotNull(attribute);
            
        }
    }
}
