// Copyright (c) Stride contributors (https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Stride.Core.Presentation.Quantum.View;
using Stride.Core.Presentation.Quantum.ViewModels;
using Stride.Assets.Models;

namespace Stride.Assets.Presentation.TemplateProviders
{
    public class AnimationFrameBoxTemplateProvider : NodeViewModelTemplateProvider
    {
        public override string Name { get { return "AnimationFrameBoxTemplateProvider"; } }

        public override bool MatchNode(NodeViewModel node)
        {
            return (node.Name.Equals(nameof(AnimationAssetDurationUnchecked.StartAnimationTimeBox)) || node.Name.Equals(nameof(AnimationAssetDurationUnchecked.EndAnimationTimeBox)));
        }
    }
}
