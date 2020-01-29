// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;
using System.ComponentModel;
using System.Diagnostics;
using Xenko.Core;
using Xenko.Engine;
using Xenko.Games;

namespace Xenko.UI.Controls
{
    [DataContract(nameof(AnimatedImageElement))]
    [DebuggerDisplay("AnimatedImageElement - Name={Name}")]
    public class AnimatedImageElement : ImageElement
    {
        private bool isAnimating = true;
        private bool checkCanAnimate = true;
        private bool restart;
        private int frames;
        private long frameTicks;
        private long startTicks;

        /// <summary>
        /// If true, the image element will automatically animate the frames when visible.
        /// </summary>
        [DataMember]
        [Display(category: BehaviorCategory)]
        [DefaultValue(true)]
        public bool IsAnimating
        {
            get { return isAnimating; }
            set
            {
                if (value == isAnimating)
                    return;

                isAnimating = value;
                restart = true;
            }
        }

        [DataMemberIgnore]
        public bool CanAnimate { get; private set; }

        protected override void OnSourceChanged()
        {
            base.OnSourceChanged();
            checkCanAnimate = true;
        }

        protected override void Update(GameTime time)
        {
            // I have to wait until Update for the sprites to be loaded/populated in the sheet
            if (checkCanAnimate)
            {
                checkCanAnimate = false;

                CanAnimate = false;
                if (Source is IAnimatableSpriteProvider spriteProvider)
                {
                    frames = Source.SpritesCount;
                    if (frames >= 2)
                    {
                        CanAnimate = true;
                        frameTicks = TimeSpan.FromSeconds(1.0 / frames).Ticks;
                        restart = true;
                    }
                }
            }

            var isVisible = IsVisible;
            if (!isVisible)
            {
                restart = true;
                return;
            }

            if (IsAnimating && CanAnimate)
            {
                if (restart)
                {
                    restart = false;

                    // start animation
                    ((IAnimatableSpriteProvider)Source).CurrentFrame = 0;
                    startTicks = time.Total.Ticks;
                }
                else
                {
                    if ((time.Total.Ticks - startTicks) < frameTicks)
                        return;

                    var spriteProvider = (IAnimatableSpriteProvider)Source;
                    spriteProvider.CurrentFrame = (spriteProvider.CurrentFrame + 1) % frames;
                    startTicks += frameTicks;
                }
            }

            base.Update(time);
        }
    }
}
