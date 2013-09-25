﻿// -----------------------------------------------------------------------
// <copyright file="MojoForceBoss.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace sgll.net.Core.Entieies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class MojoForceBoss : AbstractMojoEntity
    {
        public bool IsInChallange { get; set; }
        public MojoForceBossBattle Battle { get; set; }
    }

    public class MojoForceBossBattle
    {
        public int Left { get; set; }
        public int BossTimeout { get; set; }
        public int AttackFree { get; set; }
        public int AttackTimeout { get; set; }
        public int AttackRMCost { get; set; }
    }
}
