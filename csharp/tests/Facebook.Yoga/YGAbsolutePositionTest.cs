/**
 * Copyright (c) 2014-present, Facebook, Inc.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

// @Generated by gentest/gentest.rb from gentest/fixtures/YGAbsolutePositionTest.html

using System;
using NUnit.Framework;

namespace Facebook.Yoga
{
    [TestFixture]
    public class YGAbsolutePositionTest
    {
        [Test]
        public void Test_absolute_layout_width_height_start_top()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Start = 10;
            root_child0.Top = 10;
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_width_height_end_bottom()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.End = 10;
            root_child0.Bottom = 10;
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(80f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(80f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_start_top_end_bottom()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Start = 10;
            root_child0.Top = 10;
            root_child0.End = 10;
            root_child0.Bottom = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(80f, root_child0.LayoutWidth);
            Assert.AreEqual(80f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(80f, root_child0.LayoutWidth);
            Assert.AreEqual(80f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_width_height_start_top_end_bottom()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Start = 10;
            root_child0.Top = 10;
            root_child0.End = 10;
            root_child0.Bottom = 10;
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_do_not_clamp_height_of_absolute_node_to_height_of_its_overflow_hidden_parent()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.FlexDirection = YogaFlexDirection.Row;
            root.Overflow = YogaOverflow.Hidden;
            root.Width = 50;
            root.Height = 50;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Start = 0;
            root_child0.Top = 0;
            root.Insert(0, root_child0);

            YogaNode root_child0_child0 = new YogaNode(config);
            root_child0_child0.Width = 100;
            root_child0_child0.Height = 100;
            root_child0.Insert(0, root_child0_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(50f, root.LayoutWidth);
            Assert.AreEqual(50f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(100f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(50f, root.LayoutWidth);
            Assert.AreEqual(50f, root.LayoutHeight);

            Assert.AreEqual(-50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(100f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_within_border()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.MarginLeft = 10;
            root.MarginTop = 10;
            root.MarginRight = 10;
            root.MarginBottom = 10;
            root.PaddingLeft = 10;
            root.PaddingTop = 10;
            root.PaddingRight = 10;
            root.PaddingBottom = 10;
            root.BorderLeftWidth = 10;
            root.BorderTopWidth = 10;
            root.BorderRightWidth = 10;
            root.BorderBottomWidth = 10;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Left = 0;
            root_child0.Top = 0;
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.PositionType = YogaPositionType.Absolute;
            root_child1.Right = 0;
            root_child1.Bottom = 0;
            root_child1.Width = 50;
            root_child1.Height = 50;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode(config);
            root_child2.PositionType = YogaPositionType.Absolute;
            root_child2.Left = 0;
            root_child2.Top = 0;
            root_child2.MarginLeft = 10;
            root_child2.MarginTop = 10;
            root_child2.MarginRight = 10;
            root_child2.MarginBottom = 10;
            root_child2.Width = 50;
            root_child2.Height = 50;
            root.Insert(2, root_child2);

            YogaNode root_child3 = new YogaNode(config);
            root_child3.PositionType = YogaPositionType.Absolute;
            root_child3.Right = 0;
            root_child3.Bottom = 0;
            root_child3.MarginLeft = 10;
            root_child3.MarginTop = 10;
            root_child3.MarginRight = 10;
            root_child3.MarginBottom = 10;
            root_child3.Width = 50;
            root_child3.Height = 50;
            root.Insert(3, root_child3);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(10f, root.LayoutX);
            Assert.AreEqual(10f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(40f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);

            Assert.AreEqual(20f, root_child2.LayoutX);
            Assert.AreEqual(20f, root_child2.LayoutY);
            Assert.AreEqual(50f, root_child2.LayoutWidth);
            Assert.AreEqual(50f, root_child2.LayoutHeight);

            Assert.AreEqual(30f, root_child3.LayoutX);
            Assert.AreEqual(30f, root_child3.LayoutY);
            Assert.AreEqual(50f, root_child3.LayoutWidth);
            Assert.AreEqual(50f, root_child3.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(10f, root.LayoutX);
            Assert.AreEqual(10f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(40f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);

            Assert.AreEqual(20f, root_child2.LayoutX);
            Assert.AreEqual(20f, root_child2.LayoutY);
            Assert.AreEqual(50f, root_child2.LayoutWidth);
            Assert.AreEqual(50f, root_child2.LayoutHeight);

            Assert.AreEqual(30f, root_child3.LayoutX);
            Assert.AreEqual(30f, root_child3.LayoutY);
            Assert.AreEqual(50f, root_child3.LayoutWidth);
            Assert.AreEqual(50f, root_child3.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_center()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.JustifyContent = YogaJustify.Center;
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_flex_end()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.JustifyContent = YogaJustify.FlexEnd;
            root.AlignItems = YogaAlign.FlexEnd;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(60f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(60f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_justify_content_center()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.JustifyContent = YogaJustify.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_center()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_center_on_child_only()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.AlignSelf = YogaAlign.Center;
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_center_and_top_position()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.JustifyContent = YogaJustify.Center;
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Top = 10;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_center_and_bottom_position()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.JustifyContent = YogaJustify.Center;
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Bottom = 10;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(50f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(50f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_center_and_left_position()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.JustifyContent = YogaJustify.Center;
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Left = 5;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(5f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(5f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_center_and_right_position()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.JustifyContent = YogaJustify.Center;
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Right = 5;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(45f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(45f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_position_root_with_rtl_should_position_withoutdirection()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Left = 72;
            root.Width = 52;
            root.Height = 52;
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(72f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(52f, root.LayoutWidth);
            Assert.AreEqual(52f, root.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(72f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(52f, root.LayoutWidth);
            Assert.AreEqual(52f, root.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_percentage_bottom_based_on_parent_height()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 200;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Top = 50.Percent();
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.PositionType = YogaPositionType.Absolute;
            root_child1.Bottom = 50.Percent();
            root_child1.Width = 10;
            root_child1.Height = 10;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode(config);
            root_child2.PositionType = YogaPositionType.Absolute;
            root_child2.Top = 10.Percent();
            root_child2.Bottom = 10.Percent();
            root_child2.Width = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(200f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(100f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(90f, root_child1.LayoutY);
            Assert.AreEqual(10f, root_child1.LayoutWidth);
            Assert.AreEqual(10f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(20f, root_child2.LayoutY);
            Assert.AreEqual(10f, root_child2.LayoutWidth);
            Assert.AreEqual(160f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(200f, root.LayoutHeight);

            Assert.AreEqual(90f, root_child0.LayoutX);
            Assert.AreEqual(100f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            Assert.AreEqual(90f, root_child1.LayoutX);
            Assert.AreEqual(90f, root_child1.LayoutY);
            Assert.AreEqual(10f, root_child1.LayoutWidth);
            Assert.AreEqual(10f, root_child1.LayoutHeight);

            Assert.AreEqual(90f, root_child2.LayoutX);
            Assert.AreEqual(20f, root_child2.LayoutY);
            Assert.AreEqual(10f, root_child2.LayoutWidth);
            Assert.AreEqual(160f, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_in_wrap_reverse_column_container()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Wrap = YogaWrap.WrapReverse;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 20;
            root_child0.Height = 20;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(20f, root_child0.LayoutWidth);
            Assert.AreEqual(20f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(20f, root_child0.LayoutWidth);
            Assert.AreEqual(20f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_in_wrap_reverse_row_container()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.FlexDirection = YogaFlexDirection.Row;
            root.Wrap = YogaWrap.WrapReverse;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 20;
            root_child0.Height = 20;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(80f, root_child0.LayoutY);
            Assert.AreEqual(20f, root_child0.LayoutWidth);
            Assert.AreEqual(20f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(80f, root_child0.LayoutY);
            Assert.AreEqual(20f, root_child0.LayoutWidth);
            Assert.AreEqual(20f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_in_wrap_reverse_column_container_flex_end()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Wrap = YogaWrap.WrapReverse;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.AlignSelf = YogaAlign.FlexEnd;
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 20;
            root_child0.Height = 20;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(20f, root_child0.LayoutWidth);
            Assert.AreEqual(20f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(20f, root_child0.LayoutWidth);
            Assert.AreEqual(20f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_in_wrap_reverse_row_container_flex_end()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.FlexDirection = YogaFlexDirection.Row;
            root.Wrap = YogaWrap.WrapReverse;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.AlignSelf = YogaAlign.FlexEnd;
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 20;
            root_child0.Height = 20;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(20f, root_child0.LayoutWidth);
            Assert.AreEqual(20f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(20f, root_child0.LayoutWidth);
            Assert.AreEqual(20f, root_child0.LayoutHeight);
        }

    }
}