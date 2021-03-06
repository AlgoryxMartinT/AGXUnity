﻿using B_Component = Brick.Physics.Component;

namespace AGXUnity.BrickUnity
{
  public static class BrickUtils
  {
    public static B_Component LoadComponentFromFile(string filePath, string nodePath)
    {
      Brick.AgxBrick._BrickModule.Init();

      var loader = new Brick.AgxBrick.BrickFileLoader();
      var simWrapper = loader.LoadFile(filePath, nodePath);
      return simWrapper.Scene;
    }
  }
}