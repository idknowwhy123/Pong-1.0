 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
    
    public class ShootHandler : MonoBehaviour,IUpdateSelectedHandler,IPointerDownHandler,IPointerUpHandler
    {
        public bool isPressed;
        public UnityEvent onLongPress;
        public void OnUpdateSelected(BaseEventData data)
        {
            if (isPressed)
            {
             onLongPress?.Invoke();
            }
            
        }
        public void OnPointerDown(PointerEventData data)
        {
            isPressed = true;
        }
        public void OnPointerUp(PointerEventData data)
        {
            isPressed = false;
        }
    }