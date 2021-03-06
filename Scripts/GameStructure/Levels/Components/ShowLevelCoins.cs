﻿//----------------------------------------------
// Flip Web Apps: Game Framework
// Copyright © 2016 Flip Web Apps / Mark Hewitt
//
// Please direct any bugs/comments/suggestions to http://www.flipwebapps.com
// 
// The copyright owner grants to the end user a non-exclusive, worldwide, and perpetual license to this Asset
// to integrate only as incorporated and embedded components of electronic games and interactive media and 
// distribute such electronic game and interactive media. End user may modify Assets. End user may otherwise 
// not reproduce, distribute, sublicense, rent, lease or lend the Assets. It is emphasized that the end 
// user shall not be entitled to distribute or transfer in any way (including, without, limitation by way of 
// sublicense) the Assets in any other way than as integrated components of electronic games and interactive media. 

// The above copyright notice and this permission notice must not be removed from any files.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//----------------------------------------------

using GameFramework.GameStructure.Levels.Messages;
using GameFramework.GameStructure.Levels.ObjectModel;
using GameFramework.UI.Other.Components.AbstractClasses;
using UnityEngine;
using UnityEngine.Assertions;

namespace GameFramework.GameStructure.Levels.Components
{
    /// <summary>
    /// Show the number of coins that have been collected for the level has.
    /// </summary>
    [AddComponentMenu("Game Framework/GameStructure/Levels/ShowLevelCoins")]
    [HelpURL("http://www.flipwebapps.com/unity-assets/game-framework/game-structure/levels/")]
    public class ShowLevelCoins : ShowValueAnimatedMessaging<int, LevelCoinsChangedMessage>
    {
        Level _level;

        /// <summary>
        /// Cache level reference and call base class.
        /// </summary>
        public override void Start()
        {
            Assert.IsTrue(GameManager.IsActive, "You need to add a LevelManager to your scene to be able to use ShowCoins.");

            _level = LevelManager.Instance.Level;
            base.Start();
        }


        /// <summary>
        /// Return the number of coins that have been collected for the level.
        /// </summary>
        /// <returns></returns>
        public override int GetValueFromMessage(LevelCoinsChangedMessage message)
        {
            return message == null ? _level.Coins : message.NewCoins;
        }
    }
}