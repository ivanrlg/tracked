﻿using Api.Analysers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Segments {
    [TestClass]
    public class TarlandOrangeSegment {
        [TestMethod]
        public void Tarland_Orange_Blue1() {
            Assert.IsFalse(SegmentAnalyser.LocationsMatch(TestSegments.TarlandOrangeSegment, TestSegments.TarlandBlue1).MatchesSegment);
        }

        [TestMethod]
        public void Tarland_Orange_Blue2() {
            Assert.IsFalse(SegmentAnalyser.LocationsMatch(TestSegments.TarlandOrangeSegment, TestSegments.TarlandBlue2).MatchesSegment);
        }

        [TestMethod]
        public void Tarland_Orange_Blue3() {
            Assert.IsFalse(SegmentAnalyser.LocationsMatch(TestSegments.TarlandOrangeSegment, TestSegments.TarlandBlue3).MatchesSegment);
        }

        [TestMethod]
        public void Tarland_Orange_Blue4() {
            Assert.IsFalse(SegmentAnalyser.LocationsMatch(TestSegments.TarlandOrangeSegment, TestSegments.TarlandBlue4).MatchesSegment);
        }

        [TestMethod]
        public void Tarland_Orange_Red1() {
            Assert.IsFalse(SegmentAnalyser.LocationsMatch(TestSegments.TarlandOrangeSegment, TestSegments.TarlandRed1).MatchesSegment);
        }

        [TestMethod]
        public void Tarland_Orange_Red2() {
            Assert.IsFalse(SegmentAnalyser.LocationsMatch(TestSegments.TarlandOrangeSegment, TestSegments.TarlandRed2).MatchesSegment);
        }

        [TestMethod]
        public void Tarland_Orange_Orange1() {
            Assert.IsTrue(SegmentAnalyser.LocationsMatch(TestSegments.TarlandOrangeSegment, TestSegments.TarlandOrange1).MatchesSegment);
        }

        [TestMethod]
        public void Tarland_Orange_Orange2() {
            Assert.IsTrue(SegmentAnalyser.LocationsMatch(TestSegments.TarlandOrangeSegment, TestSegments.TarlandOrange2).MatchesSegment);
        }
    }
}
