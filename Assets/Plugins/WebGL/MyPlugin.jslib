mergeInto(LibraryManager.library, {
  MoveCallback: function (direction, xpos, ypos) {
    window.dispatchReactUnityEvent(
      "MoveCallback",
      Pointer_stringify(direction),
      xpos,
      ypos
    );
  },
});
