﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.Domain.Entities
{
    public class SavingsGoal : SoftDeleteEntity
    {
        /// <summary>
        /// Gets or sets name
        /// </summary>
        public String Name { get; protected set; }

        /// <summary>
        /// Gets or sets description
        /// </summary>
        public String Description { get; protected set; }

        /// <summary>
        /// Gets or sets goal value
        /// </summary>
        public Decimal GoalValue { get; protected set; }

        /// <summary>
        /// Gets or sets actual value
        /// </summary>
        public Decimal Value { get; protected set; }
    }
}
