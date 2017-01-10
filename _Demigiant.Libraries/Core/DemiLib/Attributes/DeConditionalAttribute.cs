﻿// Author: Daniele Giardini - http://www.demigiant.com
// Created: 2017/01/10 13:59
// License Copyright (c) Daniele Giardini

using UnityEngine;

#pragma warning disable 1591
namespace DG.DemiLib.Attributes
{
    /// <summary>
    /// <code>Property attribute</code>
    /// <para>Shows/hides or enables/disables the property depending on the given conditions</para>
    /// </summary>
    public class DeConditionalAttribute : PropertyAttribute
    {
        internal DeCondition condition;
        internal ConditionalBehaviour behaviour;

        /// <summary>
        /// Shows/enables the property only if the condition is met
        /// </summary>
        /// <param name="propertyToCompare">Name of the property to check for conditions</param>
        /// <param name="value">Property value to compare (boolean)</param>
        /// <param name="behaviour">Behaviour in case condition is not met</param>
        public DeConditionalAttribute(string propertyToCompare, bool value, ConditionalBehaviour behaviour = ConditionalBehaviour.Disable)
        {
            this.condition = new DeCondition(propertyToCompare, value);
            this.behaviour = behaviour;
        }
        /// <summary>
        /// Shows/enables the property only if the condition is met
        /// </summary>
        /// <param name="propertyToCompare">Name of the property to check for conditions</param>
        /// <param name="value">Property value to compare (string)</param>
        /// <param name="conditionType">Condition type</param>
        /// <param name="behaviour">Behaviour in case condition is not met</param>
        public DeConditionalAttribute(string propertyToCompare, string value, StringCondition conditionType = StringCondition.Is, ConditionalBehaviour behaviour = ConditionalBehaviour.Disable)
        {
            this.condition = new DeCondition(propertyToCompare, value, conditionType);
            this.behaviour = behaviour;
        }
        /// <summary>
        /// Shows/enables the property only if the condition is met
        /// </summary>
        /// <param name="propertyToCompare">Name of the property to check for conditions</param>
        /// <param name="value">Property value to compare (float)</param>
        /// <param name="conditionType">Condition type</param>
        /// <param name="behaviour">Behaviour in case condition is not met</param>
        public DeConditionalAttribute(string propertyToCompare, float value, FloatCondition conditionType = FloatCondition.Is, ConditionalBehaviour behaviour = ConditionalBehaviour.Disable)
        {
            this.condition = new DeCondition(propertyToCompare, value, conditionType);
            this.behaviour = behaviour;
        }
        /// <summary>
        /// Shows/enables the property only if the condition is met
        /// </summary>
        /// <param name="propertyToCompare">Name of the property to check for conditions</param>
        /// <param name="value">Property value to compare (float)</param>
        /// <param name="conditionType">Condition type</param>
        /// <param name="behaviour">Behaviour in case condition is not met</param>
        public DeConditionalAttribute(string propertyToCompare, int value, IntCondition conditionType = IntCondition.Is, ConditionalBehaviour behaviour = ConditionalBehaviour.Disable)
        {
            this.condition = new DeCondition(propertyToCompare, value, conditionType);
            this.behaviour = behaviour;
        }
    }
}