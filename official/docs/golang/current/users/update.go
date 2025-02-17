package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	user, _ := client.RetrieveMe()
	rechargeThreshold := "50.00"

	user, _ = client.UpdateUser(
		&easypost.UserOptions{
			RechargeAmount: &rechargeThreshold,
		},
	)

	fmt.Println(user)
}
