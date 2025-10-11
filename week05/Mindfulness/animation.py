import time
import sys

frames = [
    ".....",
    "o....",
    "Oo...",
    "oOo..",
    ".oOo.",
    "..oOo",
    "...oO",
    "....o",
    ".....",
    "....o",
    "...oO",
    "..oOo",
    ".oOo.",
    "oOo..",
    "Oo...",
    "o....",
    "....."
]

def bouncing_orb(duration_seconds=5, speed=0.1):
    end_time = time.time() + duration_seconds
    i = 0
    while time.time() < end_time:
        sys.stdout.write("\r" + frames[i])
        sys.stdout.flush()
        time.sleep(speed)
        i = (i + 1) % len(frames)
    sys.stdout.write("\r     \r")  # limpia al final

if __name__ == "__main__":
    print("Get ready...")
    bouncing_orb(5)
    print("Done!")
