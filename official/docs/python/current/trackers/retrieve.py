import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

tracker = easypost.Tracker.retrieve("trk_...")

print(tracker)
