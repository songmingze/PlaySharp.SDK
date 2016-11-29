// <copyright file="IAbilityTrackerRepository.cs" company="PlaySharp">
//    Copyright (c) 2016 PlaySharp.
// </copyright>
namespace PlaySharp.SDK.Composition.Repositories
{
    using System;
    using System.Security;

    using PlaySharp.SDK.Composition.Metadata;
    using PlaySharp.SDK.Trackers;
    using PlaySharp.Toolkit.Helper.Annotations;

    [PublicAPI]
    [SecuritySafeCritical]
    public interface IAbilityTrackerRepository :
        IAbilityTrackerRepository<Lazy<IAbilityTracker, IAbilityTrackerMetadata>>
    {
    }
}