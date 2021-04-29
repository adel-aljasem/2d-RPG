using System;
using System.Collections.Generic;

public delegate void MovementDelegate(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarrying, ToolEffect toolEffect,
    bool isUsingTollRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown,
    bool isLifingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown,
    bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown,
    bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
    bool idleUp, bool idleDown, bool idleLeft, bool idleRight);

public static class EventHandler
{
    public static event Action<InventoryLocation, List<InventoryItem>> InventoryUpdatedEvent;

    public static void CallInventoryUpdatedEvent(InventoryLocation inventoryLocation,List<InventoryItem> inventoryItems)
    {
        if(InventoryUpdatedEvent != null)
        {
            InventoryUpdatedEvent(inventoryLocation, inventoryItems);
        }
    }


    public static event MovementDelegate MovementEvent;

    public static void CallMovementEvent(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarrying, ToolEffect toolEffect,
    bool isUsingTollRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown,
    bool isLifingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown,
    bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown,
    bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
    bool idleUp, bool idleDown, bool idleLeft, bool idleRight)
    {
        if (MovementEvent != null)
        {
            MovementEvent(inputX, inputY,
                 isWalking, isRunning, isIdle, isCarrying,
                 toolEffect,
                 isUsingTollRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown,
                 isLifingToolRight, isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown,
                 isPickingRight, isPickingLeft, isPickingUp, isPickingDown,
                 isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp, isSwingingToolDown,
                 idleUp, idleDown, idleLeft, idleRight);
        }
    }
}