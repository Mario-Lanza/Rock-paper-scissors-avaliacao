using FluentAssertions;
using NUnit.Framework;
using RockPaperScissors.Rules.Moves;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissorsTests.Rules.Moves
{
    [TestFixture]
    public class ContainerMovesTests
    {
        [Test]
        public void Should_be_recorded_all_moves()
        {
            var allMoves = GetAllMoveBaseClass();

            var containerMoves = ContainerMoves.GetAllMoves();

            containerMoves.Should().BeEquivalentTo(allMoves);
        }

        [Test]
        public void Should_be_returned_all_initials_moves()
        {
            var allInitialsMoves = GetAllMoveBaseClass().Select(x => x.InitialMove);

            var containerInitials = ContainerMoves.GetAllInitials();

            containerInitials.Should().BeEquivalentTo(allInitialsMoves);
        }

        private IEnumerable<MoveBase> GetAllMoveBaseClass()
        {
            return typeof(MoveBase)
            .Assembly.GetTypes()
            .Where(t => t.IsSubclassOf(typeof(MoveBase)) && !t.IsAbstract)
            .Select(t => (MoveBase)Activator.CreateInstance(t));
        }
    }
}
