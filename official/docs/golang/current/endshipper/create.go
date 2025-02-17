package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	endshipper, _ := client.CreateEndShipper(
		&easypost.Address{
			Name:    "FOO BAR",
			Company: "BAZ",
			Street1: "164 TOWNSEND STREET UNIT 1",
			Street2: "UNIT 1",
			City:    "SAN FRANCISCO",
			State:   "CA",
			Zip:     "94107",
			Country: "US",
			Phone:   "555-555-5555",
			Email:   "FOO@EXAMPLE.COM",
		},
	)

	fmt.Println(endshipper)
}
