﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DynamicTranslator.Extensions
{
    public static class EventHandlerExtensions
    {
        /// <summary>
        ///     Raises given event safely with given arguments.
        /// </summary>
        /// <param name="eventHandler">The event handler</param>
        /// <param name="sender">Source of the event</param>
        public static void InvokeSafely(this PropertyChangedEventHandler eventHandler, object sender)
        {
            eventHandler.InvokeSafely(sender, (PropertyChangedEventArgs)EventArgs.Empty);
        }

        /// <summary>
        ///     Raises given event safely with given arguments.
        /// </summary>
        /// <param name="eventHandler">The event handler</param>
        /// <param name="sender">Source of the event</param>
        /// <param name="e">Event argument</param>
        public static void InvokeSafely(this PropertyChangedEventHandler eventHandler, object sender, PropertyChangedEventArgs e)
        {
            eventHandler?.Invoke(sender, e);
        }

        public static void InvokeSafely(this EventHandler eventHandler, object sender)
        {
            eventHandler.InvokeSafely(sender, EventArgs.Empty);
        }

        /// <summary>
        ///     Raises given event safely with given arguments.
        /// </summary>
        /// <param name="eventHandler">The event handler</param>
        /// <param name="sender">Source of the event</param>
        /// <param name="e">Event argument</param>
        public static void InvokeSafely(this EventHandler eventHandler, object sender, EventArgs e)
        {
            eventHandler?.Invoke(sender, e);
        }

        /// <summary>
        ///     Raises given event safely with given arguments.
        /// </summary>
        /// <typeparam name="TEventArgs">Type of the <see cref="EventArgs" /></typeparam>
        /// <param name="eventHandler">The event handler</param>
        /// <param name="sender">Source of the event</param>
        /// <param name="e">Event argument</param>
        public static void InvokeSafely<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e)
            where TEventArgs : EventArgs
        {
            eventHandler?.Invoke(sender, e);
        }

        public static Task InvokeSafelyAsync<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e)
            where TEventArgs : EventArgs
        {
            return Task.Run(() => eventHandler?.Invoke(sender, e));
        }
    }
}
